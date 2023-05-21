﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace Laptop_price_predictor
{
    public partial class Model
    {
        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process. For more information on how to load data, see aka.ms/loaddata.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainPipeline(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"Category", @"Category"),new InputOutputColumnPair(@"Screen Size(in inches)", @"Screen Size(in inches)"),new InputOutputColumnPair(@"Screen Resolution", @"Screen Resolution"),new InputOutputColumnPair(@"CPU", @"CPU"),new InputOutputColumnPair(@"GHz", @"GHz"),new InputOutputColumnPair(@"RAM(in Gb)", @"RAM(in Gb)"),new InputOutputColumnPair(@"HDD Size(in Gb)", @"HDD Size(in Gb)"),new InputOutputColumnPair(@"SSD Size(In GB)", @"SSD Size(In GB)"),new InputOutputColumnPair(@"HYBRID Size(In GB)", @"HYBRID Size(In GB)"),new InputOutputColumnPair(@"FLASH STORAGE Size(In GB)", @"FLASH STORAGE Size(In GB)"),new InputOutputColumnPair(@"GPU", @"GPU"),new InputOutputColumnPair(@"OS", @"OS"),new InputOutputColumnPair(@"Weight (in kg)", @"Weight (in kg)")})      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Category",@"Screen Size(in inches)",@"Screen Resolution",@"CPU",@"GHz",@"RAM(in Gb)",@"HDD Size(in Gb)",@"SSD Size(In GB)",@"HYBRID Size(In GB)",@"FLASH STORAGE Size(In GB)",@"GPU",@"OS",@"Weight (in kg)"}))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.Regression.Trainers.FastTreeTweedie(new FastTreeTweedieTrainer.Options(){NumberOfLeaves=7,MinimumExampleCountPerLeaf=14,NumberOfTrees=81,MaximumBinCountPerFeature=541,FeatureFraction=0.99999999,LearningRate=0.344762863502263,LabelColumnName=@"Price (in php)",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}
