namespace Trakt.Api;

/// <summary>
/// The trakt.tv URI class.
/// </summary>
public static class TraktUris
{
    /// <summary>
    /// The base URL.
    /// </summary>
    public const string BaseUrl = "https://api.trakt.tv";

    /// <summary>
    /// The client id.
    /// </summary>
    public const string ClientId = "037b090935aec832129591da8c77127fd622e9ae93a454fcb479ad7f1d6e5377";

    /// <summary>
    /// The client secret.
    /// </summary>
    public const string ClientSecret = "338abc43639e7a9853631ab4d02ee4589b9fd7d21c0afd9cb66984529e194725";

    /// <summary>
    /// The device code URI.
    /// </summary>
    public const string DeviceCode = BaseUrl + "/oauth/device/code";

    /// <summary>
    /// The device token URI.
    /// </summary>
    public const string DeviceToken = BaseUrl + "/oauth/device/token";

    /// <summary>
    /// The access token URI.
    /// </summary>
    public const string AccessToken = BaseUrl + "/oauth/token";

    /// <summary>
    /// The token revoke URI.
    /// </summary>
    public const string RevokeToken = BaseUrl + "/oauth/revoke";

    /// <summary>
    /// The collection sync add URI.
    /// </summary>
    public const string SyncCollectionAdd = BaseUrl + "/sync/collection";

    /// <summary>
    /// The collection sync remove URI.
    /// </summary>
    public const string SyncCollectionRemove = BaseUrl + "/sync/collection/remove";

    /// <summary>
    /// The watched history add URI.
    /// </summary>
    public const string SyncWatchedHistoryAdd = BaseUrl + "/sync/history";

    /// <summary>
    /// The watched history remove URI.
    /// </summary>
    public const string SyncWatchedHistoryRemove = BaseUrl + "/sync/history/remove";

    /// <summary>
    /// The ratings add URI.
    /// </summary>
    public const string SyncRatingsAdd = BaseUrl + "/sync/ratings";

    /// <summary>
    /// The scrobble start URI.
    /// </summary>
    public const string ScrobbleStart = BaseUrl + "/scrobble/start";

    /// <summary>
    /// The scrobble pause URI.
    /// </summary>
    public const string ScrobblePause = BaseUrl + "/scrobble/pause";

    /// <summary>
    /// The scrobble stop URI.
    /// </summary>
    public const string ScrobbleStop = BaseUrl + "/scrobble/stop";

    /// <summary>
    /// The watched movies URI.
    /// </summary>
    public const string WatchedMovies = BaseUrl + "/sync/watched/movies";

    /// <summary>
    /// The watched shows URI.
    /// </summary>
    public const string WatchedShows = BaseUrl + "/sync/watched/shows";

    /// <summary>
    /// The paused movies URI.
    /// </summary>
    public const string PausedMovies = BaseUrl + "/sync/playback/movies";

    /// <summary>
    /// The paused shows URI.
    /// </summary>
    public const string PausedEpisodes = BaseUrl + "/sync/playback/episodes";

    /// <summary>
    /// The collected movies URI.
    /// </summary>
    public const string CollectedMovies = BaseUrl + "/sync/collection/movies?extended=metadata";

    /// <summary>
    /// The collected series URI.
    /// </summary>
    public const string CollectedShows = BaseUrl + "/sync/collection/shows?extended=metadata";

    /// <summary>
    /// The movies recommendations URI.
    /// </summary>
    public const string RecommendationsMovies = BaseUrl + "/recommendations/movies";

    /// <summary>
    /// The shows recommendations URI.
    /// </summary>
    public const string RecommendationsShows = BaseUrl + "/recommendations/shows";
}
