function [ cell ] = KeyExpansion( Key , SBox ,RconDec )

cell{1}=Key;

for i = 2 : 11
    for j = 1 : 4
        if(j==1)
            % Rotate last column
            LastCol=cell{i-1}(:,4);     
            x=LastCol(1,1);             
            LastCol(1,1)=LastCol(2,1);
            LastCol(2,1)=LastCol(3,1);
            LastCol(3,1)=LastCol(4,1);
            LastCol(4,1)=x;
            %
            sb=SubBytes(LastCol,SBox);
            res=colwisexor(sb,cell{i-1}(:,j));
            res=colwisexor(res,RconDec(:,i-1));
            
            cell{i}(:,j)=res;
        else
            cell{i}(:,j)=colwisexor(cell{i-1}(:,j),cell{i}(:,j-1));
        end
    end
    
end


end

