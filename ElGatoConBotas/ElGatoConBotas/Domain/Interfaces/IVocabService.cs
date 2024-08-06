using ElGatoConBotas.Domain.Entities;
using System.Collections.Generic;

namespace ElGatoConBotas.Domain.Interfaces
{
    public interface IVocabService
    {
        List<Vocabulary> GetVocabularies();
        void AddVocabulary(Vocabulary v);
        void RemoveVocabulary(Vocabulary v);
        void UpdateVocabulary(Vocabulary v);
    }
}
