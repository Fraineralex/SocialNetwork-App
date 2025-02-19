﻿using Microsoft.AspNetCore.Http;
using SocialNetwork.Core.Application.ViewModels.Comment;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Core.Application.ViewModels.Post
{
    public class SavePostViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter the content of the post")]
        [DataType(DataType.Text)]
        public string? Content { get; set; }

        public string? ImagePath { get; set; }
       
        [Required(ErrorMessage = "The posts must be a user id")]
        public int UserId { get; set; }

        public List<CommentViewModel>? Comments { get; set; }

        public IFormFile? ImageFile { get; set; }

        public string? Created { get; set; }

    }

}
