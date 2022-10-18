namespace TailwindTraders.Api.Core.Services.Implementations;

internal class ProfileService : TailwindTradersServiceBase, IProfileService
{
    private readonly ProfilesDbContext _profileRepository;

    public ProfileService(ProfilesDbContext profileRepository, IMapper mapper, IConfiguration configuration) : base(mapper, configuration)
    {
        _profileRepository = profileRepository;
    }
}