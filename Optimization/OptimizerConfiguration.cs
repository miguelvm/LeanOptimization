﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
    [Serializable]
    public class OptimizerConfiguration : IOptimizerConfiguration
    {
        /// <summary>
        /// The initial size of the population
        /// </summary>
        public int PopulationSize { get; set; } = 12;

        /// <summary>
        /// The maximum population
        /// </summary>
        public int PopulationSizeMaximum { get; set; } = 24;

        /// <summary>
        /// The maximum generations
        /// </summary>
        public int Generations { get; set; } = 1000;

        /// <summary>
        /// Quit if fitness does not improve for generations
        /// </summary>
        public int StagnationGenerations { get; set; } = 10;

        /// <summary>
        /// Number of parallel backtests
        /// </summary>
        public int MaxThreads { get; set; } = 8;

        /// <summary>
        /// Override config.json setting
        /// </summary>
        public string AlgorithmTypeName { get; set; }

        /// <summary>
        /// Full path to config.json
        /// </summary>
        public string ConfigPath { get; set; } = "../../../../Lean/Launcher/config.json";

        /// <summary>
        /// 1 or 2 point crossover
        /// </summary>
        public bool OnePointCrossover { get; set; } = false;

        /// <summary>
        /// Override config.json setting
        /// </summary>
        public string AlgorithmLocation { get; set; }

        /// <summary>
        /// By default results with negative Sharpe or CAR are ignored
        /// </summary>
        public bool IncludeNegativeReturn { get; set; }

        /// <summary>
        /// Type name of fitness function. Defaults to fitness based on Sharpe Ratio
        /// </summary>
        public string FitnessTypeName { get; set; } = "Optimization.OptimizerFitness";

        /// <summary>
        /// Override config.json setting
        /// </summary>
        public string DataFolder { get; set; }

    }
}
