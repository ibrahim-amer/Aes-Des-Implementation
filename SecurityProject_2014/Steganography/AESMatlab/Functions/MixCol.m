function [ OutMat ] = MixCol( InMatrix,MatMixCol )
%--------------------------------------------------------------------------
for  k=1 : 4
for i=1 : 4
    for j=1 : 4
         resMat(j,1)=fifieldsmul(InMatrix(j,k),MatMixCol(i,j));
    end
    OutMat(i,k)=bunchbitxor(resMat');
end
end


