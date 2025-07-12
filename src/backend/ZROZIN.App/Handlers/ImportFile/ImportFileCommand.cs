
using FluentValidation;
using MediatR;
using ZROZIN.App.Handlers.Helpers;

namespace ZROZIN.App.Handlers.ImportFile;

public record ImportFileCommand(string FileName) : IRequest<Result>;

public class ImportFileCommandValidator : AbstractValidator<ImportFileCommand>
{
    public ImportFileCommandValidator()
    {
        RuleFor(x => x.FileName).NotEmpty();
    }
}

public class ImportFileCommandHandler : IRequestHandler<ImportFileCommand, Result>
{
    public Task<Result> Handle(ImportFileCommand command, CancellationToken cancellationToken)
    {
        return Task.FromResult(Result.Success());
    }
}