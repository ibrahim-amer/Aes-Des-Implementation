function [ out ] = loadmatfile( path )
out = load(path);
out = out.mat;
end

