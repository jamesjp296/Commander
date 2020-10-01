using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var Commands =new List<Command>
            {
               new Command {Id=0, HowTo="Test",Line="Test Line",Platform="Test Platform"},
               new Command {Id=1, HowTo="Test1",Line="Test Line1",Platform="Test Platform1"},
               new Command {Id=2, HowTo="Test2",Line="Test Line2",Platform="Test Platform2"} 
            };

            return Commands;
        }
        

        public Command GetCommandById(int id)
        {
            return new Command {Id=0, HowTo="Test",Line="Test Line",Platform="Test Platform"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }

}