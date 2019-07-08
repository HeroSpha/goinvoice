using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Interface
{
    public interface INoteRepository
    {
        Task<Note> AddNoteAsync(Note note);
        Task<Note> UpdateNoteAsync(Note note);
        Task<bool> DeleteNoteAsync(int nodeId);
        Task<List<Note>> GetNotes(int QuotationId);
    }
}
