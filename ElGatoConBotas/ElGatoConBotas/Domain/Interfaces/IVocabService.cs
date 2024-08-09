using ElGatoConBotas.Domain.Entities;

namespace ElGatoConBotas.Domain.Interfaces
{
    public interface IVocabService
    {
        List<Vocabulary> GetVocabularies();
        Vocabulary AddVocabularies(Vocabulary vocabulary);
        Vocabulary DeleteVocabularies(Vocabulary vocabulary);
        Vocabulary UpdateVocabularies(Vocabulary vocabulary);
    }
}
