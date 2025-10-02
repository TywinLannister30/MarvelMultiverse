using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface ITagSelector
{
    Tag GetTag(string name, string specialization = null, string reminder = null);

    List<Tag> GetTags();
}
