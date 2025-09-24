using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface ITagSelector
{
    Tag GetTag(string name, string specialization = null);

    List<Tag> GetTags();
}
