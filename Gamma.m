function RGB = Gamma(image, gFactor)
    RGB = uint8( 255 * (double(image)/255).^(1/(gFactor-1)));
end