cd ..
tar cf package/package.tar package/package.json package/index.js package/metavcoin-cli.js package/metavcoin-node.js package/Release
tar --delete -f package/package.tar package/Release/z3-linux package/Release/z3-osx
tar rf package/package.tar package/Release/z3-linux package/Release/z3-osx --mode=775
cd package
gzip package.tar

