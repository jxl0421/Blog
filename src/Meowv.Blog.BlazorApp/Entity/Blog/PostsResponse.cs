﻿using System.Collections.Generic;

namespace Meowv.Blog.BlazorApp.Entity.Blog
{
    public class PostsResponse
    {
        /// <summary>
        /// 年份
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Posts
        /// </summary>
        public IEnumerable<PostBriefDto> Posts { get; set; }
    }
}