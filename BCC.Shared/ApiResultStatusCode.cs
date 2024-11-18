
namespace BCC.Shared;

public enum ApiResultStatusCode : int
{
    /// <summary>
    /// Operation completed successfully.
    /// </summary>
    [Display(Name = "Operation completed successfully.")]
    Success = 200,
    /// <summary>
    /// An error occurred on the server.
    /// </summary>
    [Display(Name = "An error occurred on the server.")]
    ServerError = 500,
    /// <summary>
    /// The submitted parameters are not valid.
    /// </summary>
    [Display(Name = "The submitted parameters are not valid.")]
    BadRequest = 400,
    /// <summary>
    /// Not found.
    /// </summary>
    [Display(Name = "Not found.")]
    NotFound = 404,
    /// <summary>
    /// Found.
    /// </summary>
    [Display(Name = "Found.")]
    Found = 410,
    /// <summary>
    /// The list is empty.
    /// </summary>
    [Display(Name = "The list is empty.")]
    ListEmpty = 204,
    /// <summary>
    /// A processing error occurred.
    /// </summary>
    [Display(Name = "A processing error occurred.")]
    LogicError = 409,
    /// <summary>
    /// Authentication error.
    /// </summary>
    [Display(Name = "Authentication error.")]
    UnAuthorized = 403,

    /// <summary>
    /// The process cannot continue due to business reasons.
    /// </summary>
    [Display(Name = "The process cannot continue due to business reasons.")]
    ProcessCanceled = 1002,

    /// <summary>
    /// No changes were made in the database.
    /// </summary>
    [Display(Name = "No changes were made in the database.")]
    NoAffectedRow = 412
}
