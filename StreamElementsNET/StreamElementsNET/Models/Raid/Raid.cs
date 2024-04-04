﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamElementsNET.Models.Raid
{
    public class Raid
    {
        public string Username { get; }
        public string UserId { get; }
        public string DisplayName { get; }
        public int Amount { get; }
        public string Avatar { get; }

        public Raid(string username, string userId, string displayName, int amount, string avatar)
        {
            Username = username;
            UserId = userId;
            DisplayName = displayName;
            Amount = amount;
            Avatar = avatar;
        }
    }
}
