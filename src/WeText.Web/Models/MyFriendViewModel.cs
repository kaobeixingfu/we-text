﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeText.Web.Models
{
    public class MyFriendViewModel
    {
        public string SelectedUserId { get; set; }

        public IEnumerable<SelectListItem> UserNames { get; set; }

        [Required(ErrorMessage = "Field 'Invitation Letter' is required")]
        public string InvitationLetter { get; set; }
    }
}