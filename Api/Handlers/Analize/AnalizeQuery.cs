using Api.Contracts;
using MediatR;

namespace Api.Handlers.Analize;

public sealed record AnalizeQuery() : IRequest<AnalizeResponse>;