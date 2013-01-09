﻿using System;
using System.Threading.Tasks;
using Xunit;

namespace Nocto.Tests.Integration
{
    public class UsersEndpointTests
    {
        public class TheGetUserAsyncMethod
        {
            [Fact(Skip = "Restore this after the CI Server is set up")]
            public async Task ReturnsSpecifiedUser()
            {
                var github = new GitHubClient { Login = "xapitestaccountx", Password = "octocat11" };

                // Get a user by username
                var user = await github.User.Get("tclem");

                Assert.Equal("GitHub", user.Company);
            }
        }

        public class TheGetAuthenticatedUserAsyncMethod
        {
            [Fact(Skip = "Restore this after the CI Server is set up")]
            public async Task ReturnsSpecifiedUser()
            {
                var github = new GitHubClient { Login = "xapitestaccountx", Password = "octocat11" };

                // Get a user by username
                var user = await github.User.Current();

                Assert.Equal("xapitestaccountx", user.Login);
            }
        }

        public class TheGetUsersAsyncMethod
        {
            [Fact(Skip = "Restore this after the CI Server is set up")]
            public async Task ReturnsAllUsers()
            {
                var github = new GitHubClient();

                // Get a user by username
                var users = await github.User.GetAll();

                Console.WriteLine(users);
            }
        }
    }
}