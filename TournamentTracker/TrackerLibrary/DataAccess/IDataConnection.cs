﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{/// <summary>
/// Interface is like a promise
/// That you will do specific things
/// </summary>
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();


    }
}
