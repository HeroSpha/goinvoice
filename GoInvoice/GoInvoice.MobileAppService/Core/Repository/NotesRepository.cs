using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class NotesRepository : INoteRepository
    {
        public Task<Note> AddNoteAsync(Note note)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNoteAsync(int nodeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Note>> GetNotes(int QuotationId)
        {
            throw new NotImplementedException();
        }

        public Task<Note> UpdateNoteAsync(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
