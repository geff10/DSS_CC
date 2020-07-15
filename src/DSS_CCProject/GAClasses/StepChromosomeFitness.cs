using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSS_CCProject.GAClasses
{
    public class StepChromosomeFitness : IFitness
    {
        private double fullPenalty;
        public double Evaluate(IChromosome chromosome)
        {
            fullPenalty = 0;
            Simulate(chromosome as StepChromosome);
            return fullPenalty;
        }

        private void Simulate(StepChromosome genome)
        {
            throw new NotImplementedException();
        }
    }
}
