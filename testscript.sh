#!/bin/bash
# GNU bash, version 4.3.46
sudo apt install unzip                     && \
sudo apt-get --assume-yes install npm      && \
mkdir /tmp/downloadedApp                   && \
cd /tmp/downloadedApp                      && \
wget $1 -o app.zip                         && \
unzip app.zip                              && \
rm app.zip                                 && \
npm i                                      && \
npm start
