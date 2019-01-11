echo Update Info.plist
pwd
ls -la
line="\<string\>com.companyname\<\/string\>"
rep="<string>${CFBundleIdentifier}</string>"
pattern="{gsub(/${line}/,\"${rep}\");}1"
echo pattern: $pattern
mv Info.plist Info.plist.bak
cat Info.plist.bak | awk $pattern > Info.plist
cat Info.plist
