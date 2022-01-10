function main(a,b,c)
	local d=b*b-4*a*c
	if d>=0 then
		local x1=(-1*b+d^0.5)/(2*a)
		local x2=(-1*b-d^0.5)/(2*a)
		return d,x1,x2
	else
		x1="Discriminant < 0"
		x2="Discriminant < 0"
		return d,x1,x2
	end
end