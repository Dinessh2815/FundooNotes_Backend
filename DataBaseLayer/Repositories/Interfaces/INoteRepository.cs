using DataBaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLayer.Repositories.Interfaces
{
    public interface INoteRepository
    {
        Task AddAsync(Note note);
        Task UpdateAsync(Note note);
        Task DeleteAsync(Note note);
        Task<List<Note>> GetAllAsync(int userId);

        // Owner-only
        Task<Note?> GetByIdAsync(int noteId, int userId);


        // Shared (owner or collaborator)
        Task<Note?> GetByIdAsync(int noteId);

        Task<List<Note>> GetAllIncludingCollaborationsAsync(int userId);

        Task<List<Note>> GetDeletedAsync(int userId);

        Task<Note?> GetDeletedByIdAsync(int noteId, int userId);

    }


}
