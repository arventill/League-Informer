﻿using LeagueInformer.Services;
using Xunit;

namespace LeagueInformer_UnitTests.Services
{
    public class ConnectionServiceTest
    {
        private readonly ConnectionService _connection;

        public ConnectionServiceTest()
        {
            _connection = new ConnectionService();
        }

        [Fact]
        public void ConnectionService_RequestReturnedSuccess()
        {
            //Assert
            Assert.True(_connection.HasInternetConnection());
        }
    }
}
