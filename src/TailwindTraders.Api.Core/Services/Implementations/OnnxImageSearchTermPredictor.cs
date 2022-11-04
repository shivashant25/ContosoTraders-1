using System.Reflection;
using SixLabors.ImageSharp.Advanced;
using SixLabors.Primitives;

namespace TailwindTraders.Api.Core.Services.Implementations;

public class OnnxImageSearchTermPredictor : IImageSearchTermPredictor
{
    private readonly ILogger<OnnxImageSearchTermPredictor> _logger;

    private readonly InferenceSession _session;

    public OnnxImageSearchTermPredictor(IWebHostEnvironment environment, ILogger<OnnxImageSearchTermPredictor> logger)
    {
        var assemblyFilePath = Assembly.GetExecutingAssembly().Location;
        var assemblyFolder = Path.GetDirectoryName(assemblyFilePath);
        var onnxFilePath = Path.Combine(assemblyFolder, "products.onnx");
        var onnxFileFullPath = Path.GetFullPath(onnxFilePath);

        _session = new InferenceSession(onnxFileFullPath);
        _logger = logger;
    }

    public Task<string> PredictSearchTermAsync(Stream imageStream, CancellationToken cancellationToken = default)
    {
        var data = ConvertImageToTensor(imageStream);
        var input = NamedOnnxValue.CreateFromTensor("data", data);
        using var output = _session.Run(new[] {input});
        var prediction = output.First(i => i.Name == "classLabel").AsEnumerable<string>().First();
        return Task.FromResult(prediction);
    }

    private static DenseTensor<float> ConvertImageToTensor(Stream imageStream)
    {
        var data = new DenseTensor<float>(new[] {1, 3, 224, 224});
        using var image = Image.Load(imageStream);
        image.Mutate(ctx => ctx.Resize(new ResizeOptions
        {
            Size = new Size(224, 224),
            Mode = ResizeMode.Stretch
        }));
        for (var x = 0; x < image.Width; x++)
        for (var y = 0; y < image.Height; y++)
        {
            var color = image.GetPixelRowSpan(y)[x];
            data[0, 0, x, y] = color.B;
            data[0, 1, x, y] = color.G;
            data[0, 2, x, y] = color.R;
        }

        return data;
    }
}