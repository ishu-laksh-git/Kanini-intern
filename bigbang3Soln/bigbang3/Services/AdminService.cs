﻿using bigbang3.Interfaces;
using bigbang3.Models;
using bigbang3.Models.DTO;

namespace bigbang3.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepo<Agent, string> _agentRepo;
        public AdminService(IRepo<Agent,string> agentRepo)
        {
            _agentRepo = agentRepo;
        }
        public async Task<Agent?> UpdateStatus(StatusDTO status)
        {
            try
            {
                var agent = await _agentRepo.Get(status.AgentEmail);
                if(agent == null) { return null; }
                agent.IsApproved = status.Status;
                var updatedAgent = await _agentRepo.Update(agent);
                if(updatedAgent == null) { return null; }
                return updatedAgent;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
