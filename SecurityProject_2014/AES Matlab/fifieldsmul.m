function [ out ] = fifieldsmul( element, prod )

if (prod == 1)
    out = element;
elseif (prod == 2)
    out = element .* 2;
    if(out >= 256)
        out = bitxor(out, 256);
    end
     if (bitand(element, 128) == 128)
       out=bitxor(out,27);
     end
elseif (prod == 3)
    r1 = fifieldsmul(element, 2);
    r2 = fifieldsmul(element, 1);
    out = bitxor(r1, r2);
elseif (prod == 9)
    %*8
    r1 = fifieldsmul(element, 2);
    r2 = fifieldsmul(r1, 2);
    r3 = fifieldsmul(r2, 2);
    out = bunchbitxor(r3, element);
elseif (prod == 11)
%     r1 = fifieldsmul(element, 9);
%     r2 = fifieldsmul(element, 2);
%     out = bunchbitxor(r1, r2);
      %*8
      r1 = fifieldsmul(element, 2);
      r2 = fifieldsmul(r1, 2);
      r3 = fifieldsmul(r2, 2);
      %*2  
      r4 = fifieldsmul(element, 2);
      %*1
      r5 = fifieldsmul(element, 1);
      
      out = bunchbitxor(r3, r4, r5);
elseif (prod == 13)
    %*8
    r1 = fifieldsmul(element, 2);
    r2 = fifieldsmul(r1, 2);
    r3 = fifieldsmul(r2, 2);
    
    %*4
    r4 = fifieldsmul(element, 2);
    r5 = fifieldsmul(r4, 2);
    
    r6 = fifieldsmul(element, 1);
    out = bunchbitxor(r3, r5, r6);
    
    
elseif (prod == 14)
    r1 = fifieldsmul(element, 2);
    r2 = fifieldsmul(r1, 2);
    r3 = fifieldsmul(r2, 2);  %*8
    
    r4 = fifieldsmul(element, 2);  
    r5 = fifieldsmul(r4, 2);    %*4
    
    r6 = fifieldsmul(element, 2);
    
    out = bunchbitxor(r3, r5, r6);
end

end

