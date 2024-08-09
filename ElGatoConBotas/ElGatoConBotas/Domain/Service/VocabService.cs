using ElGatoConBotas.Database;
using ElGatoConBotas.Domain.Service;
using ElGatoConBotas.Domain.Entities;
using ElGatoConBotas.Domain.Interfaces;


namespace ElGatoConBotas.Domain.Service
{
    public class VocabService : IVocabService
    {
        protected readonly AppDbContext _dbContext;
        public VocabService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Vocabulary> GetVocabularies()
        {
            return _dbContext.Vocabularies.ToList();
        }
        public Vocabulary AddVocabularies(Vocabulary vocabulary)
        {

            _dbContext.Vocabularies.Add(vocabulary);
            _dbContext.SaveChanges();
            return vocabulary;

        }
        public Vocabulary DeleteVocabularies(Vocabulary vocabulary)
        {
            _dbContext.Vocabularies.Remove(vocabulary);
            _dbContext.SaveChanges();
            return vocabulary;
        }

        public Vocabulary UpdateVocabularies(Vocabulary vocabulary)
        {
            _dbContext.Vocabularies.Update(vocabulary);
            _dbContext.SaveChanges();
            return vocabulary;

        }
        
    }
}


