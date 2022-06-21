# transpile the file from typescript to javascript
tsc -t es5 main.ts

# run the javascript file
node main.js

# rm the js file after running so we dont get the ts errors
rm main.js