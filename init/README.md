# Run metavcoin-node as a daemon (Linux only) 

1. Install nodejs version 8
2. Install lmdb from package manager
3. Run

```
npm config set @metavcoin:registry https://www.myget.org/F/metavcoin/npm/
npm install @metavcoin/metavcoin-wallet -g
```
4. Create new file at `/etc/systemd/system/metavcoin.service` and copy the content of `metavcoin.service` to the new file.
5. Run 

```
sudo systemctl daemon reload
sudo systemctl enable metavcoin.service
sudo systemctl start metavcoin.service
```
