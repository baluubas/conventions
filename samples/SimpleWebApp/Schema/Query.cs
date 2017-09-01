using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Conventions.Relay;
using SimpleWebApp.Schema;

namespace GraphQL.Conventions.Tests.Server.Schema
{
    public class Query
    {
        [Description("Retrieve book/author by its globally unique ID.")]
        public Task<INode> Node(UserContext context, Id id) =>
            context.Get<INode>(id);

        public Viewer Viewer() => new Viewer();
    }
}
