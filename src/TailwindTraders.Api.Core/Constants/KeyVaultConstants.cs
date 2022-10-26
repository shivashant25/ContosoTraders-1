namespace TailwindTraders.Api.Core.Constants;

internal class KeyVaultConstants
{
    #region secrets

    public static readonly string SecretNameJwtAudience = "jwtAudience";

    public static readonly string SecretNameJwtAuthority = "jwtAuthority";

    public static readonly string SecretNameImagesEndpoint = "imagesEndpoint";

    public static readonly string SecretNameCartsDbConnectionString = "cartsDbConnectionString";

    public static readonly string SecretNameProductsDbConnectionString = "productsDbConnectionString";

    public static readonly string SecretNameProfilesDbConnectionString = "profilesDbConnectionString";

    public static readonly string SecretNameStocksDbConnectionString = "stocksDbConnectionString";

    #endregion
}