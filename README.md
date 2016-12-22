# MARC
MARC is a Mobile Application Review Classifier that automatically classifies user reviews into fine grained software maintainence requests, including bug reports and feature requests.

##Features

####Automatic User Review Extraction
MARC provides a feature for extracting recent user reviews from the iOS app store. Simply enter the app store ID for any app in the iOS app store and MARC will import upto 500 most recent user reviews.

####Text Processing Features

#####Stemming
MARC uses Porter Stemmer ([http://www.tartarus.org/~martin/PorterStemmer](http://www.tartarus.org/~martin/PorterStemmer)) to reduce words to their morphological roots by removing derivational and inflectional suffixes.

#####Stop-word Removal
MARC provides a feature for removing English words that are considered too generic (eg. the, in, will).

#####Sentence Extraction
Since a single user review might include more than one maintainence request, MARC processes user reviews a sentence at a time.

##Installation
MARC requires [.Net 4.5.2](https://support.microsoft.com/en-us/kb/2901907) to run. MARC can be installed by running the installer from the following directory :

MARC Installer -> Debug -> MARC Installer.msi

MARC provides default training datasets (BOF Dataset.arff and BOW Dataset.arff) in the installation directory (C:\Program Files (x86)\LSU MARC\MARC 1.0 - Mobile App Review Classifier\InputData). You can either edit this training dataset or use one of your own. However, please make sure that the training dataset you use follows the same format as the default training dataset.

##Working on Source Code 
In order to open and modify the C# source project you will need:
- Visual Studio 2015 [Free Community Edition](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)
- [.Net 4.5.2](https://support.microsoft.com/en-us/kb/2901907). Once you have loaded the project open MARC 1.0.sln in src directory in Visual Studio and select MARC as the startup project. You may also have to link references from the project directory.
