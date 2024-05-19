function RGB = Saturation(image, sFactor) 
    RGB = image;
    HSV = rgb2hsv(RGB);
    % HSV(:, :, 2) = HSV(:, :, 2) * 2.0;
    % or add:
    HSV(:, :, 2) = HSV(:, :, 2) + (sFactor/10.0);
    HSV(HSV > 1) = 1;  % Limit values
    RGB = hsv2rgb(HSV);
end