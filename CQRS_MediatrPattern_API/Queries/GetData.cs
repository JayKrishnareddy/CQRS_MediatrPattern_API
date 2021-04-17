using CQRS_MediatrPattern_API.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_MediatrPattern_API.Queries
{
    public static class GetData
    {
        #region Query /Command
        //Data we need to execute
        public record Query(int Id) : IRequest<Response>;
        #endregion

        #region Handler
        //Writing Business logic and returns response.
        public class Handler : IRequestHandler<Query, Response>
        {
            private readonly Repository _repository;
            public Handler(Repository repository)
            {   
                _repository = repository;
            }
            public async Task<Response> Handle(Query query, CancellationToken cancellationToken)
            {
                var result = _repository.ToDos.FirstOrDefault(c => c.Id.Equals(query.Id));
                return result == null ? null : new Response(result.Id, result.Task, result.IsCompleted);
            }
        }
        #endregion

        #region Response
        //Data we want to return
            public record Response(int Id, string Task, bool IsCompleted);
        #endregion
    }
}
