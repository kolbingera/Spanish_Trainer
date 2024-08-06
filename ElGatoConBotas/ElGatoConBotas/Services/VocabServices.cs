using ElGatoConBotas.Database;
using ElGatoConBotas.Domain.Entities;
using ElGatoConBotas.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ElGatoConBotas.Services
{
    public class VocabServices : IVocabService
    {
        private readonly AppDbContext _context;

        public VocabServices(AppDbContext context)
        {
            _context = context;
        }

        public List<Vocabulary> GetVocabularies()
        {
            return _context.Vocabularies.ToList();
        }

        public void AddVocabulary(Vocabulary v)
        {
            _context.Vocabularies.Add(v);
            _context.SaveChanges();
        }

        public void RemoveVocabulary(Vocabulary v)
        {
            _context.Vocabularies.Remove(v);
            _context.SaveChanges();
        }

        public void UpdateVocabulary(Vocabulary v)
        {
            _context.Vocabularies.Update(v);
            _context.SaveChanges();
        }
    }
}
