using BtdStats.Data.Models;
using Refit;

namespace BtdStats.Data.Services;

public interface IStatsniteClient
{
    [Get("/towers")]
    Task<IList<Tower>> GetTowers();

    [Get("/tower/{towerId}")]
    Task<Tower> GetTower(string towerId);

    [Get("/towers?id=true")]
    Task<IList<TowerId>> GetAllTowerIds();
}