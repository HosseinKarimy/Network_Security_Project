﻿using System.ComponentModel.DataAnnotations;

namespace Models;

public class UserModel
{
    public string Username { get; set; }
    public string SaltedHashedPassword { get; set; }
}