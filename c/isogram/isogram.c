#include "isogram.h"
#include "string.h"

bool is_isogram(const char phrase[])
{
    if(!phrase){
        return false;
    }
    int len = strlen(phrase);
    if(len != 0){
        for(int i=0; i<len; i++){
            if(phrase[i] == ' '||phrase[i] == '-'){
                continue;
            }
            for(int j=i+1; j<len; j++){
                if(phrase[i] == phrase[j]||phrase[i]+32 == phrase[j]||phrase[i] == phrase[j]+32){
                    return false;
                }
            }
        }
    }
    return true;
}
