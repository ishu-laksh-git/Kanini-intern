﻿using InternUserManagement.Models.DTO;

namespace InternUserManagement.Interfaces
{
    public interface IGenerateToken
    {
        public string GenerateToken(UserDTOcs user);
    }


}
