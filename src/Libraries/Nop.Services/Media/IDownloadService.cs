<<<<<<< HEAD
﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Nop.Core.Domain.Media;

namespace Nop.Services.Media
{
    /// <summary>
    /// Download service interface
    /// </summary>
    public partial interface IDownloadService
    {
        /// <summary>
        /// Gets a download
        /// </summary>
        /// <param name="downloadId">Download identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the download
        /// </returns>
        Task<Download> GetDownloadByIdAsync(int downloadId);

        /// <summary>
        /// Gets a download by GUID
        /// </summary>
        /// <param name="downloadGuid">Download GUID</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the download
        /// </returns>
        Task<Download> GetDownloadByGuidAsync(Guid downloadGuid);

        /// <summary>
        /// Deletes a download
        /// </summary>
        /// <param name="download">Download</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task DeleteDownloadAsync(Download download);

        /// <summary>
        /// Inserts a download
        /// </summary>
        /// <param name="download">Download</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task InsertDownloadAsync(Download download);

        /// <summary>
        /// Gets the download binary array
        /// </summary>
        /// <param name="file">File</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the download binary array
        /// </returns>
        Task<byte[]> GetDownloadBitsAsync(IFormFile file);
    }
=======
﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Nop.Core.Domain.Media;

namespace Nop.Services.Media
{
    /// <summary>
    /// Download service interface
    /// </summary>
    public partial interface IDownloadService
    {
        /// <summary>
        /// Gets a download
        /// </summary>
        /// <param name="downloadId">Download identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the download
        /// </returns>
        Task<Download> GetDownloadByIdAsync(int downloadId);

        /// <summary>
        /// Gets a download by GUID
        /// </summary>
        /// <param name="downloadGuid">Download GUID</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the download
        /// </returns>
        Task<Download> GetDownloadByGuidAsync(Guid downloadGuid);

        /// <summary>
        /// Deletes a download
        /// </summary>
        /// <param name="download">Download</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task DeleteDownloadAsync(Download download);

        /// <summary>
        /// Inserts a download
        /// </summary>
        /// <param name="download">Download</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task InsertDownloadAsync(Download download);

        /// <summary>
        /// Gets the download binary array
        /// </summary>
        /// <param name="file">File</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the download binary array
        /// </returns>
        Task<byte[]> GetDownloadBitsAsync(IFormFile file);
    }
>>>>>>> 174426a8e1a9c69225a65c26a93d9aa871080855
}