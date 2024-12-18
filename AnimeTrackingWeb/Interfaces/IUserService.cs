using AnimeTrackingWeb.Models;

namespace AnimeTrackingWeb.Interfaces;

/// <summary>
/// Сервис взаимодействия с БД.
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Получить идентификаторы выбранных тайтлов.
    /// </summary>
    /// <param name="chatId">Идентификатор чата пользователя.</param>
    /// <returns>Коллекция выбранных идентификаторов.</returns>
    ICollection<int> GetUserTitleIds(long chatId);
    
    /// <summary>
    /// Проверить выбранность тайтла у пользователя.
    /// </summary>
    /// <param name="chatId">Идентификатор чата пользователя.</param>
    /// <param name="titleId">Идентификатор тайтла.</param>
    /// <returns>Признак выбранности.</returns>
    bool CheckUserTitleId(long chatId, int titleId);

    /// <summary>
    /// Добавить в таблицу пользователя выбранные тайтлы.
    /// </summary>
    /// <param name="chatId">Идентификатор чата пользователя.</param>
    /// <param name="titleIds">Коллекция тайтлов.</param>
    /// <param name="jobIds">Коллекция идентификаторов джобов.</param>
    void AddUserTitleIds(long chatId, ICollection<int> titleIds, IDictionary<int, ICollection<string>> jobIds);

    /// <summary>
    /// Получить удаляемые тайтлы пользователя.
    /// </summary>
    /// <param name="chatId">Идентификатор чата пользователя.</param>
    /// <returns>Удаляемые джобы.</returns>
    ICollection<string> GetDeletedUserTitles(long chatId);
}