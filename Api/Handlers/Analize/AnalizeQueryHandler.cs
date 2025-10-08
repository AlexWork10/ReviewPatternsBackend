using Api.Contracts;
using MediatR;

namespace Api.Handlers.Analize;

public sealed class AnalizeQueryHandler : IRequestHandler<AnalizeQuery, AnalizeResponse>
{
    public Task<AnalizeResponse> Handle(AnalizeQuery request, CancellationToken ct)
    {
        return Task.FromResult(new AnalizeResponse("ok"));
    }
}