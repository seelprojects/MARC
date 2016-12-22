using java.io;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weka.classifiers.bayes;
using weka.classifiers.meta;
using weka.core;
using weka.filters.unsupervised.attribute;

/*Notes for Project
    Generated WEKA.dll from weka.jar using IKVM and added to reference
    Added same version OF IKVM to Project that we used to generate weka.dll with
    Added MONO.C#
*/

namespace WekaClassifier
{
    public class WekaClassifier
    {

        public string error { get; set; }

        const int percentSplit = 70;
        private List<string> tempAllClassification = new List<string>();

        public string classification { get; set; }
        public string allOutputText { get; set; }

        public List<string> AllClassification { get; set; }

        /// <summary>
        /// This is the constructor for BOW single review classification
        /// </summary>
        /// <param name="singleReviewBOW"></param>
        public WekaClassifier(List<string> inputBoWList, string trainingFilePath, string directoryName)
        {
            ConstructBOWArffFile(inputBoWList, directoryName);
            //FilteredNaiveBayes("BOW", trainingFilePath, directoryName);
            FilteredSVM("BOW", trainingFilePath, directoryName);

        }

        /// <summary>
        /// This is the constructor for BOF  user reviews.
        /// </summary>
        /// <param name="inputFramesList"></param>
        public WekaClassifier(List<List<string>> inputBoFList, string trainingFilePath, string directoryName)
        {
            ConstructFramesArffFile(inputBoFList, directoryName);
            //FilteredNaiveBayes("BOF", trainingFilePath, directoryName);
            FilteredSVM("BOF", trainingFilePath, directoryName);
        }

        /// <summary>
        /// Method to construct BOW Arff File. Input is the list of strings of BOWs
        /// </summary>
        /// <param name="inputBOW"></param>
        private void ConstructBOWArffFile(List<string> inputBOW, string directoryName)
        {
            //var directoryName = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString());
            var testDatatsetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\Test.arff";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(testDatatsetFilePath))
            {
                file.WriteLine("@relation Test");
                file.WriteLine();
                file.WriteLine("@attribute text string");
                file.WriteLine("@attribute @@class@@ {BugReport,FeatureRequest,Other}");
                file.WriteLine();
                file.WriteLine("@data");

                foreach (string line in inputBOW)
                {
                    file.WriteLine("'" + line + " " + "',?");
                }
                file.Close();
            }    
        }

        
        /// <summary>
        /// This is the method to construct BOF Arff file. Input is list of list of strings
        /// </summary>
        /// <param name="inputFrames"></param>
        private void ConstructFramesArffFile(List<List<string>> inputFrames, string directoryName)
        {
            //var directoryName = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString());
            var testDatatsetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\Test.arff";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(testDatatsetFilePath))
            {
                file.WriteLine("@relation Test");
                file.WriteLine();
                file.WriteLine("@attribute text string");
                file.WriteLine("@attribute @@class@@ {BugReport,FeatureRequest,Other}");
                file.WriteLine();
                file.WriteLine("@data");

                foreach (List<string> line in inputFrames)
                {
                    file.WriteLine();
                    file.Write("'");
                    foreach (string data in line)
                    {
                        file.Write(data + " ");
                    }
                    file.Write("',?");
                }
            }
        }

        //private void NaiveBayesDirect()
        //{
        //    try
        //    {
        //        weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader(@"test.arff"));
        //        insts.setClassIndex(insts.numAttributes() - 1);

        //        weka.classifiers.Classifier cl = new weka.classifiers.bayes.NaiveBayes();
        //        System.Console.WriteLine("Performing " + percentSplit + "% split evaluation.");

        //        //randomize the order of the instances in the dataset.
        //        weka.filters.Filter myRandom = new weka.filters.unsupervised.attribute.StringToWordVector();
        //        myRandom.setInputFormat(insts);
        //        insts = weka.filters.Filter.useFilter(insts, myRandom);

        //        int trainSize = insts.numInstances() * percentSplit / 100;
        //        int testSize = insts.numInstances() - trainSize;
        //        weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

        //        cl.buildClassifier(train);
        //        int numCorrect = 0;
        //        for (int i = trainSize; i < insts.numInstances(); i++)
        //        {
        //            weka.core.Instance currentInst = insts.instance(i);
        //            double predictedClass = cl.classifyInstance(currentInst);
        //            if (predictedClass == insts.instance(i).classValue())
        //                numCorrect++;
        //        }
        //        System.Console.WriteLine(numCorrect + " out of " + testSize + " correct (" +
        //                   (double)((double)numCorrect / (double)testSize * 100.0) + "%)");
        //    }
        //    catch (java.lang.Exception ex)
        //    {
        //        ex.printStackTrace();
        //    }
        //}

        /// <summary>
        /// Filtered Naive Bayes Classification with type specified. i.e. BOF or BOW
        /// </summary>
        /// <param name="type"></param>
        private void FilteredNaiveBayes(string type, string trainingFilePath, string directoryName)
        {
            try
            {
                var trainingDatatsetFilePath = "";
                if (type == "BOF")
                {
                    trainingDatatsetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\BOF Dataset.arff";

                }
                else
                {
                    trainingDatatsetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\BOW Dataset.arff";
                }
                
                var testDatasetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\Test.arff";

                if (trainingFilePath != null)
                {
                    trainingDatatsetFilePath = trainingFilePath;
                }

                java.io.BufferedReader trainReader = new BufferedReader(new FileReader(trainingDatatsetFilePath));//File with text examples
                BufferedReader classifyReader = new BufferedReader(new FileReader(testDatasetFilePath));//File with text to classify

                Instances trainInsts = new Instances(trainReader);
                Instances classifyInsts = new Instances(classifyReader);

                trainInsts.setClassIndex(trainInsts.numAttributes() - 1);
                
                classifyInsts.setClassIndex(classifyInsts.numAttributes() - 1);

                FilteredClassifier model = new FilteredClassifier();

                StringToWordVector stringtowordvector = new StringToWordVector();
                stringtowordvector.setTFTransform(true);
                model.setFilter(new StringToWordVector());
                model.setClassifier(new NaiveBayes());
                model.buildClassifier(trainInsts);

                for (int i = 0; i < classifyInsts.numInstances(); i++)
                {
                    classifyInsts.instance(i).setClassMissing();
                    double cls = model.classifyInstance(classifyInsts.instance(i));
                    classifyInsts.instance(i).setClassValue(cls);
                    classification = cls == 0 ? "Bug Report"
                                    : cls == 1 ? "Feature Request"
                                    : "Other";
                    tempAllClassification.Add(classification);
                }
                AllClassification = tempAllClassification;
            }
            catch (Exception o)
            {
                error = o.ToString();
            }
        }



        /// <summary>
        /// Filtered Support Vector Machine Classification with type specified. i.e. BOF or BOW
        /// </summary>
        /// <param name="type"></param>
        private void FilteredSVM(string type, string trainingFilePath, string directoryName)
        {
            try
            {
                var trainingDatatsetFilePath = "";
                if (type == "BOF")
                {
                    trainingDatatsetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\BOF Dataset.arff";
                }
                else
                {
                    trainingDatatsetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\BOW Dataset.arff";
                }

                var testDatasetFilePath = directoryName.ToString() + "\\InputData\\TrainingDatasets\\Test.arff";

                // If training file path is supplied then use it.
                if (trainingFilePath != null)
                {
                    trainingDatatsetFilePath = trainingFilePath;
                }

                java.io.BufferedReader trainReader = new BufferedReader(new FileReader(trainingDatatsetFilePath));//File with text examples
                BufferedReader classifyReader = new BufferedReader(new FileReader(testDatasetFilePath));//File with text to classify

                Instances trainInsts = new Instances(trainReader);
                Instances classifyInsts = new Instances(classifyReader);

                trainInsts.setClassIndex(trainInsts.numAttributes() - 1);

                classifyInsts.setClassIndex(classifyInsts.numAttributes() - 1);

                FilteredClassifier model = new FilteredClassifier();

                StringToWordVector stringtowordvector = new StringToWordVector();
                stringtowordvector.setTFTransform(true);
                model.setFilter(new StringToWordVector());

                weka.classifiers.Classifier smocls = new weka.classifiers.functions.SMO();

                smocls.setOptions(weka.core.Utils.splitOptions("-C 1.0 -L 0.001 -P 1.0E-12 -N 0 -V -1 -W 1 -K \"weka.classifiers.functions.supportVector.Puk -C 250007 -O 1.0 -S 1.0\""));


                //smocls.setOptions(weka.core.Utils.splitOptions("-C 1.0 -L 0.0010 -P 1.0E-12 -N 0 -V -1 -W 1 -K \"weka.classifiers.functions.supportVector.PolyKernel -C 250007 -E 1.0\""));




                model.setClassifier(smocls);
                model.buildClassifier(trainInsts);

                for (int i = 0; i < classifyInsts.numInstances(); i++)
                {
                    classifyInsts.instance(i).setClassMissing();
                    double cls = model.classifyInstance(classifyInsts.instance(i));
                    classifyInsts.instance(i).setClassValue(cls);
                    classification = cls == 0 ? "Bug Report"
                                    : cls == 1 ? "Feature Request"
                                    : "Other";
                    tempAllClassification.Add(classification);

                }
                AllClassification = tempAllClassification;
            }
            catch (Exception o)
            {

                error = o.ToString();
            }
        }



    }
}
