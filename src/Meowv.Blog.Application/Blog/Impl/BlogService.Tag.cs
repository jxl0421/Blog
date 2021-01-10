﻿using Meowv.Blog.Dto.Blog;
using Meowv.Blog.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meowv.Blog.Blog.Impl
{
    public partial class BlogService
    {
        /// <summary>
        /// Get tag list.
        /// </summary>
        /// <returns></returns>
        public async Task<BlogResponse<List<GetTagDto>>> GetTagsAsync()
        {
            var response = new BlogResponse<List<GetTagDto>>();

            var tags = await _tags.GetListAsync();

            var result = tags.Select(x => new GetTagDto
            {
                Name = x.Name,
                Alias = x.Alias,
                Total = _posts.GetCountByTagAsync(x.Id).Result
            }).Where(x => x.Total > 0).ToList();

            response.Result = result;
            return response;
        }
    }
}