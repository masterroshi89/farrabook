﻿using FarraBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarraBook.services
{
    public class PostService : IPostService
    {
        private readonly List<Post> _posts;

        public PostService()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post
                {
                    Id = Guid.NewGuid(),
                    Name = $"Post name{i}"
                });
            }
        }

        public Post GetPostbyId(Guid postId)
        {
            return _posts.SingleOrDefault(x => x.Id == postId);
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }

        public bool UpdatePost(Post postToUpdate)
        {
            var exists = GetPostbyId(postToUpdate.Id) != null;

            if (!exists)
                return false;

            var index = _posts.FindIndex(x =>x.Id == postToUpdate.Id);
            _posts[index] = postToUpdate;
            return true;

        }
    }
}
