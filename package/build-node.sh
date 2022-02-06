#!/bin/sh

rm -r Release
cd ..
rm -r src/Node/bin/Release
msbuild src /property:Configuration=Release /t:Node:rebuild
cd package
cp -r ../src/Node/bin/Release .
cp ../packages/FSharp.Core/lib/net45/FSharp.Core.dll Release/
cp fstar.exe.config Release/

touch ./Release/.npmignore
npm pack .
