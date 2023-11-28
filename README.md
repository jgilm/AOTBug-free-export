# AOTBug-free-export
This illustrates an AOT bug when exporting a function named "free".

Build and run this sample, at the root of the repo, type `.\run` and this will build the DLL and run 
the console testing application.

In this example, there is a function in AOTNativeDLL - Class1.cs called `ReleaseMem` and it
is exported as the name "free". 


## When exported method is named "free"
#### When run from Visual Studio
<img width="860" alt="Error from within VS - exported name = free" src="https://github.com/jgilm/AOTBug-free-export/assets/2531809/f035326f-4d5b-4bd4-b08f-26df9e5712f8">

#### When run from the command line
<img width="677" alt="image" src="https://github.com/jgilm/AOTBug-free-export/assets/2531809/b22c03b6-1f96-4533-b45b-4aa7405fbb09">



## When exported method is named "release" (or anything else)
#### When run from Visual Studio
<img width="854" alt="Working Properly, exported name = release" src="https://github.com/jgilm/AOTBug-free-export/assets/2531809/d74e0e59-937c-462d-a523-b6c9fa4c1a33">

#### When run from the command line
<img width="713" alt="Command line succeeding" src="https://github.com/jgilm/AOTBug-free-export/assets/2531809/733f3f26-299e-4aea-9c90-7f9dc7cf34a3">
