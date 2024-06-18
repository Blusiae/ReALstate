﻿using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Houses.Commands.DeleteHouse
{
    internal class DeleteHouseCommandHandler
        (IHouseRepository repository): IRequestHandler<DeleteHouseCommand>
    {
        public async Task Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            
            if (entity == null)
            {
                throw new NotFoundException(nameof(House), request.Id.ToString());
            }
            await repository.Delete(entity);

        }
    }
}
