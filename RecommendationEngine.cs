using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    public class RecommendationEngine
    {
        private Queue<UserSearch> recentSearches;
        private int maxRecentSearches = 10;

        public RecommendationEngine()
        {
            recentSearches = new Queue<UserSearch>();
        }

        public void AddSearch(string searchTerm)
        {
            if (recentSearches.Count >= maxRecentSearches)
            {
                recentSearches.Dequeue();
            }
            recentSearches.Enqueue(new UserSearch { SearchTerm = searchTerm, SearchTime = DateTime.Now });
        }

        public List<string> GetRecommendations()
        {
            return recentSearches.GroupBy(s => s.SearchTerm)
                                 .OrderByDescending(g => g.Count())
                                 .ThenByDescending(g => g.Max(s => s.SearchTime))
                                 .Select(g => g.Key)
                                 .Take(5)
                                 .ToList();
        }
    }
}
