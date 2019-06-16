using System;
using System.Collections.Generic;
using System.Linq;

namespace SpearmanLib
{
        public static class SpearmanCoeff  // Spearman's Coefficient of Correlation
                                           // ρ = 1 - ((6 * sum of rank differences^2) / (n(n^2 - 1))
        {

            public static double SpearmansCoeff(this IEnumerable<int> current, IEnumerable<int> other)
            {
                double[] ranksX = GetRanking(current);
                double[] ranksY = GetRanking(other);

                var diffPair = ranksX.Zip(ranksY, (x, y) => new { x, y });
                double sigmaDiff = diffPair.Sum(s => Math.Pow(s.x - s.y, 2));
                int n = current.Count();

                double rho = 1 - ((6 * sigmaDiff) / (Math.Pow(n, 3) - n));

                return Math.Round(rho, 3);
            }

            static double[] GetRanking(IEnumerable<int> values)
            {
                var groupedValues = values.OrderByDescending(n => n)
                                          .Select((val, i) => new { Value = val, IndexedRank = i + 1 })
                                          .GroupBy(i => i.Value);

                double[] rankings = (from n in values
                                     join grp in groupedValues on n equals grp.Key
                                     select grp.Average(g => g.IndexedRank)).ToArray();

                return rankings;
            }
        }
}
