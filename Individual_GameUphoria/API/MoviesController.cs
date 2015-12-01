﻿using Individual_GameUphoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Individual_GameUphoria.API
{
    public class MoviesController : ApiController
    {
        public IEnumerable<Movie> Get()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Title="Star Wars", Director="Lucas" },
                new Movie {Id=2, Title="The Martian", Director="Scott" },
                new Movie {Id=3, Title="Ex Machina", Director="Garland" }
            };
        }
    }
}
