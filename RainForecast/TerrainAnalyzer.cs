using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainForecast
{
    public class TerrainAnalyzer
        : ITerrainAnalyzer
    {
        public int Analyze(int[] terrain)
        {
            int maxTerrainHeight = terrain.Max();
            int rainSpots = 0;
            while (maxTerrainHeight >= 0)
            {
                var terrainLength = terrain.Length -1;
                while (terrainLength >= 0)
                {
                    if (maxTerrainHeight <= terrain[terrainLength])
                    {
                        int reminingLength = terrainLength -1;
                        while (reminingLength >= 0)
                        {
                            if (maxTerrainHeight <= terrain[reminingLength])
                            {
                                rainSpots = rainSpots +  terrainLength - (reminingLength + 1);
                                terrainLength = reminingLength + 1;
                                break;
                            }
                            reminingLength--;

                        }
                    }

                    terrainLength--;
                }
                maxTerrainHeight--;
            }
            return rainSpots;

        }
    }
}
