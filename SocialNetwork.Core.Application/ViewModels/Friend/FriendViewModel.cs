﻿using SocialNetwork.Core.Application.ViewModels.Auth;
using SocialNetwork.Core.Domain.Entities;

namespace SocialNetwork.Core.Application.ViewModels.Friend
{
    public class FriendViewModel
    {
        public string? Id { get; set; }

        public int? SenderId { get; set; }

        public int? ReceptorId { get; set; }

        public bool? IsAccepted { get; set; }

        public DateTime? CreatedAt { get; set; }

        public UserViewModel? Users { get; set; }
    }
}
