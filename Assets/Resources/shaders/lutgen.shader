Shader "Hidden/Post FX/Lut Generator" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 49276
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[14];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[14];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "TONEMAPPING_FILMIC" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[14];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec3 _Balance;
						vec3 _Lift;
						vec3 _InvGamma;
						vec3 _Gain;
						vec3 _Offset;
						vec3 _Power;
						vec3 _Slope;
						float _HueShift;
						float _Saturation;
						float _Contrast;
						vec3 _ChannelMixerRed;
						vec3 _ChannelMixerGreen;
						vec3 _ChannelMixerBlue;
						vec4 unused_0_14[2];
						vec4 _LutParams;
					};
					uniform  sampler2D _Curves;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec2 u_xlatb1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					bvec3 u_xlatb3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					vec3 u_xlat6;
					float u_xlat8;
					bool u_xlatb8;
					vec2 u_xlat9;
					vec2 u_xlat10;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_LutParams.yz);
					    u_xlat1.x = u_xlat0.y * _LutParams.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _LutParams.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _LutParams.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz * _Slope.xyz + _Offset.xyz;
					    u_xlat1.xyz = log2(u_xlat0.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * _Power.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlatb2.xyz = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.xyzx).xyz;
					    {
					        vec4 hlslcc_movcTemp = u_xlat0;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? u_xlat1.x : u_xlat0.x;
					        hlslcc_movcTemp.y = (u_xlatb2.y) ? u_xlat1.y : u_xlat0.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? u_xlat1.z : u_xlat0.z;
					        u_xlat0 = hlslcc_movcTemp;
					    }
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat1 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat12 = min(u_xlat1.y, u_xlat1.w);
					    u_xlat12 = (-u_xlat12) + u_xlat1.x;
					    u_xlat2.x = u_xlat12 * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat1.y) + u_xlat1.w;
					    u_xlat5.x = u_xlat5.x / u_xlat2.x;
					    u_xlat5.x = u_xlat5.x + u_xlat1.z;
					    u_xlat1.x = u_xlat1.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat12 / u_xlat1.x;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat1 = texture(_Curves, u_xlat2.xy).yxzw;
					    u_xlat2 = texture(_Curves, u_xlat10.xy).zxyw;
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat12 = u_xlat2.x + u_xlat2.x;
					    u_xlat1.x = u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat1.x = u_xlat1.x + u_xlat1.x;
					    u_xlat12 = u_xlat12 * u_xlat1.x;
					    u_xlat1.x = dot(u_xlat0.xyz, vec3(0.212599993, 0.715200007, 0.0722000003));
					    u_xlat0.xyz = u_xlat0.xyz + (-u_xlat1.xxx);
					    u_xlat1.y = float(0.25);
					    u_xlat9.y = float(0.25);
					    u_xlat2 = texture(_Curves, u_xlat1.xy).wxyz;
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat5.x = u_xlat2.x + u_xlat2.x;
					    u_xlat12 = u_xlat12 * u_xlat5.x;
					    u_xlat12 = u_xlat12 * _Saturation;
					    u_xlat0.xyz = vec3(u_xlat12) * u_xlat0.xyz + u_xlat1.xxx;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Contrast, _Contrast, _Contrast)) + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb2 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb1.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat6.x = (u_xlatb2.y) ? u_xlat0.x : float(65504.0);
					    u_xlat6.z = (u_xlatb2.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb1.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat2.x = (u_xlatb2.x) ? u_xlat0.x : u_xlat6.x;
					    u_xlat2.y = (u_xlatb2.z) ? u_xlat0.y : u_xlat6.z;
					    u_xlat2.z = (u_xlatb1.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xyz);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat2.xyz * _Balance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = (-_Lift.xyz) + vec3(1.0, 1.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * _Gain.xyz;
					    u_xlat3.xyz = _Lift.xyz * _Gain.xyz;
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlatb3.xyz = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.xyzx).xyz;
					    {
					        vec4 hlslcc_movcTemp = u_xlat0;
					        hlslcc_movcTemp.x = (u_xlatb3.x) ? u_xlat2.x : u_xlat0.x;
					        hlslcc_movcTemp.y = (u_xlatb3.y) ? u_xlat2.y : u_xlat0.y;
					        hlslcc_movcTemp.z = (u_xlatb3.z) ? u_xlat2.z : u_xlat0.z;
					        u_xlat0 = hlslcc_movcTemp;
					    }
					    u_xlat0.xyw = max(u_xlat0.yzx, vec3(0.0, 0.0, 0.0));
					    u_xlatb1.x = u_xlat0.x>=u_xlat0.y;
					    u_xlat1.x = u_xlatb1.x ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat0.yx;
					    u_xlat3.xy = u_xlat0.xy + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat1.xxxx * u_xlat3 + u_xlat2;
					    u_xlatb1.x = u_xlat0.w>=u_xlat2.x;
					    u_xlat1.x = u_xlatb1.x ? 1.0 : float(0.0);
					    u_xlat0.xyz = u_xlat2.xyw;
					    u_xlat2.xyw = u_xlat0.wyx;
					    u_xlat2 = (-u_xlat0) + u_xlat2;
					    u_xlat0 = u_xlat1.xxxx * u_xlat2 + u_xlat0;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat9.x = abs(u_xlat4.x) + _HueShift;
					    u_xlat2 = texture(_Curves, u_xlat9.xy);
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat4.x = u_xlat2.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat9.x;
					    u_xlatb8 = 1.0<u_xlat4.x;
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat8 = (u_xlatb8) ? u_xlat5.y : u_xlat4.x;
					    u_xlatb4 = u_xlat4.x<0.0;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat8;
					    u_xlat4.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat4.xyz = fract(u_xlat4.xyz);
					    u_xlat4.xyz = u_xlat4.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat4.xyz = abs(u_xlat4.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.xyz = clamp(u_xlat4.xyz, 0.0, 1.0);
					    u_xlat4.xyz = u_xlat4.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat1.x / u_xlat5.x;
					    u_xlat4.xyz = u_xlat1.xxx * u_xlat4.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat0.xyz = u_xlat4.xyz * u_xlat0.xxx;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.x = dot(vec3(1.70504999, -0.621789992, -0.0832599998), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.130260006, 1.1408, -0.0105499998), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(-0.0240000002, -0.128969997, 1.15296996), u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat1 = texture(_Curves, u_xlat0.xw).wxyz;
					    u_xlat1.x = u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat2 = texture(_Curves, u_xlat0.yw);
					    u_xlat0 = texture(_Curves, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat1.z = clamp(u_xlat1.z, 0.0, 1.0);
					    u_xlat1.y = u_xlat2.w;
					    u_xlat1.y = clamp(u_xlat1.y, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat1 = texture(_Curves, u_xlat0.xw);
					    SV_Target0.x = u_xlat1.x;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat1 = texture(_Curves, u_xlat0.yw);
					    u_xlat0 = texture(_Curves, u_xlat0.zw);
					    SV_Target0.z = u_xlat0.z;
					    SV_Target0.z = clamp(SV_Target0.z, 0.0, 1.0);
					    SV_Target0.y = u_xlat1.y;
					    SV_Target0.y = clamp(SV_Target0.y, 0.0, 1.0);
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec3 _Balance;
						vec3 _Lift;
						vec3 _InvGamma;
						vec3 _Gain;
						vec3 _Offset;
						vec3 _Power;
						vec3 _Slope;
						float _HueShift;
						float _Saturation;
						float _Contrast;
						vec3 _ChannelMixerRed;
						vec3 _ChannelMixerGreen;
						vec3 _ChannelMixerBlue;
						vec4 _NeutralTonemapperParams1;
						vec4 _NeutralTonemapperParams2;
						vec4 _LutParams;
					};
					uniform  sampler2D _Curves;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec2 u_xlatb1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					bvec3 u_xlatb3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					vec3 u_xlat6;
					float u_xlat8;
					bool u_xlatb8;
					vec2 u_xlat9;
					vec2 u_xlat10;
					float u_xlat12;
					bool u_xlatb12;
					float u_xlat13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_LutParams.yz);
					    u_xlat1.x = u_xlat0.y * _LutParams.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _LutParams.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _LutParams.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz * _Slope.xyz + _Offset.xyz;
					    u_xlat1.xyz = log2(u_xlat0.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * _Power.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlatb2.xyz = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.xyzx).xyz;
					    {
					        vec4 hlslcc_movcTemp = u_xlat0;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? u_xlat1.x : u_xlat0.x;
					        hlslcc_movcTemp.y = (u_xlatb2.y) ? u_xlat1.y : u_xlat0.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? u_xlat1.z : u_xlat0.z;
					        u_xlat0 = hlslcc_movcTemp;
					    }
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat1 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat12 = min(u_xlat1.y, u_xlat1.w);
					    u_xlat12 = (-u_xlat12) + u_xlat1.x;
					    u_xlat2.x = u_xlat12 * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat1.y) + u_xlat1.w;
					    u_xlat5.x = u_xlat5.x / u_xlat2.x;
					    u_xlat5.x = u_xlat5.x + u_xlat1.z;
					    u_xlat1.x = u_xlat1.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat12 / u_xlat1.x;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat1 = texture(_Curves, u_xlat2.xy).yxzw;
					    u_xlat2 = texture(_Curves, u_xlat10.xy).zxyw;
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat12 = u_xlat2.x + u_xlat2.x;
					    u_xlat1.x = u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat1.x = u_xlat1.x + u_xlat1.x;
					    u_xlat12 = u_xlat12 * u_xlat1.x;
					    u_xlat1.x = dot(u_xlat0.xyz, vec3(0.212599993, 0.715200007, 0.0722000003));
					    u_xlat0.xyz = u_xlat0.xyz + (-u_xlat1.xxx);
					    u_xlat1.y = float(0.25);
					    u_xlat9.y = float(0.25);
					    u_xlat2 = texture(_Curves, u_xlat1.xy).wxyz;
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat5.x = u_xlat2.x + u_xlat2.x;
					    u_xlat12 = u_xlat12 * u_xlat5.x;
					    u_xlat12 = u_xlat12 * _Saturation;
					    u_xlat0.xyz = vec3(u_xlat12) * u_xlat0.xyz + u_xlat1.xxx;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Contrast, _Contrast, _Contrast)) + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb2 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb1.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat6.x = (u_xlatb2.y) ? u_xlat0.x : float(65504.0);
					    u_xlat6.z = (u_xlatb2.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb1.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat2.x = (u_xlatb2.x) ? u_xlat0.x : u_xlat6.x;
					    u_xlat2.y = (u_xlatb2.z) ? u_xlat0.y : u_xlat6.z;
					    u_xlat2.z = (u_xlatb1.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xyz);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat2.xyz * _Balance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = (-_Lift.xyz) + vec3(1.0, 1.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * _Gain.xyz;
					    u_xlat3.xyz = _Lift.xyz * _Gain.xyz;
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlatb3.xyz = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.xyzx).xyz;
					    {
					        vec4 hlslcc_movcTemp = u_xlat0;
					        hlslcc_movcTemp.x = (u_xlatb3.x) ? u_xlat2.x : u_xlat0.x;
					        hlslcc_movcTemp.y = (u_xlatb3.y) ? u_xlat2.y : u_xlat0.y;
					        hlslcc_movcTemp.z = (u_xlatb3.z) ? u_xlat2.z : u_xlat0.z;
					        u_xlat0 = hlslcc_movcTemp;
					    }
					    u_xlat0.xyw = max(u_xlat0.yzx, vec3(0.0, 0.0, 0.0));
					    u_xlatb1.x = u_xlat0.x>=u_xlat0.y;
					    u_xlat1.x = u_xlatb1.x ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat0.yx;
					    u_xlat3.xy = u_xlat0.xy + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat1.xxxx * u_xlat3 + u_xlat2;
					    u_xlatb1.x = u_xlat0.w>=u_xlat2.x;
					    u_xlat1.x = u_xlatb1.x ? 1.0 : float(0.0);
					    u_xlat0.xyz = u_xlat2.xyw;
					    u_xlat2.xyw = u_xlat0.wyx;
					    u_xlat2 = (-u_xlat0) + u_xlat2;
					    u_xlat0 = u_xlat1.xxxx * u_xlat2 + u_xlat0;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat9.x = abs(u_xlat4.x) + _HueShift;
					    u_xlat2 = texture(_Curves, u_xlat9.xy);
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat4.x = u_xlat2.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat9.x;
					    u_xlatb8 = 1.0<u_xlat4.x;
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat8 = (u_xlatb8) ? u_xlat5.y : u_xlat4.x;
					    u_xlatb4 = u_xlat4.x<0.0;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat8;
					    u_xlat4.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat4.xyz = fract(u_xlat4.xyz);
					    u_xlat4.xyz = u_xlat4.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat4.xyz = abs(u_xlat4.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.xyz = clamp(u_xlat4.xyz, 0.0, 1.0);
					    u_xlat4.xyz = u_xlat4.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat1.x / u_xlat5.x;
					    u_xlat4.xyz = u_xlat1.xxx * u_xlat4.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat0.xyz = u_xlat4.xyz * u_xlat0.xxx;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.x = dot(vec3(1.70504999, -0.621789992, -0.0832599998), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.130260006, 1.1408, -0.0105499998), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(-0.0240000002, -0.128969997, 1.15296996), u_xlat1.xyz);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = _NeutralTonemapperParams1.y * _NeutralTonemapperParams1.z;
					    u_xlat1.x = _NeutralTonemapperParams1.x * _NeutralTonemapperParams2.z + u_xlat12;
					    u_xlat5.xy = _NeutralTonemapperParams1.ww * _NeutralTonemapperParams2.xy;
					    u_xlat1.x = _NeutralTonemapperParams2.z * u_xlat1.x + u_xlat5.x;
					    u_xlat13 = _NeutralTonemapperParams1.x * _NeutralTonemapperParams2.z + _NeutralTonemapperParams1.y;
					    u_xlat13 = _NeutralTonemapperParams2.z * u_xlat13 + u_xlat5.y;
					    u_xlat1.x = u_xlat1.x / u_xlat13;
					    u_xlat13 = _NeutralTonemapperParams2.x / _NeutralTonemapperParams2.y;
					    u_xlat1.x = (-u_xlat13) + u_xlat1.x;
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xxx;
					    u_xlat2.xyz = _NeutralTonemapperParams1.xxx * u_xlat0.xyz + vec3(u_xlat12);
					    u_xlat2.xyz = u_xlat0.xyz * u_xlat2.xyz + u_xlat5.xxx;
					    u_xlat3.xyz = _NeutralTonemapperParams1.xxx * u_xlat0.xyz + _NeutralTonemapperParams1.yyy;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat3.xyz + u_xlat5.yyy;
					    u_xlat0.xyz = u_xlat2.xyz / u_xlat0.xyz;
					    u_xlat0.xyz = (-vec3(u_xlat13)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat1.xxx * u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz / _NeutralTonemapperParams2.www;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat1 = texture(_Curves, u_xlat0.xw).wxyz;
					    u_xlat1.x = u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat2 = texture(_Curves, u_xlat0.yw);
					    u_xlat0 = texture(_Curves, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat1.z = clamp(u_xlat1.z, 0.0, 1.0);
					    u_xlat1.y = u_xlat2.w;
					    u_xlat1.y = clamp(u_xlat1.y, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat1 = texture(_Curves, u_xlat0.xw);
					    SV_Target0.x = u_xlat1.x;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat1 = texture(_Curves, u_xlat0.yw);
					    u_xlat0 = texture(_Curves, u_xlat0.zw);
					    SV_Target0.z = u_xlat0.z;
					    SV_Target0.z = clamp(SV_Target0.z, 0.0, 1.0);
					    SV_Target0.y = u_xlat1.y;
					    SV_Target0.y = clamp(SV_Target0.y, 0.0, 1.0);
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "TONEMAPPING_FILMIC" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec3 _Balance;
						vec3 _Lift;
						vec3 _InvGamma;
						vec3 _Gain;
						vec3 _Offset;
						vec3 _Power;
						vec3 _Slope;
						float _HueShift;
						float _Saturation;
						float _Contrast;
						vec3 _ChannelMixerRed;
						vec3 _ChannelMixerGreen;
						vec3 _ChannelMixerBlue;
						vec4 unused_0_14[2];
						vec4 _LutParams;
					};
					uniform  sampler2D _Curves;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec2 u_xlatb1;
					vec4 u_xlat2;
					int u_xlati2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					bvec3 u_xlatb3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec3 u_xlat6;
					float u_xlat8;
					bvec2 u_xlatb8;
					vec2 u_xlat9;
					vec2 u_xlat10;
					float u_xlat12;
					bool u_xlatb12;
					float u_xlat13;
					int u_xlati13;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_LutParams.yz);
					    u_xlat1.x = u_xlat0.y * _LutParams.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _LutParams.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _LutParams.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz * _Slope.xyz + _Offset.xyz;
					    u_xlat1.xyz = log2(u_xlat0.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * _Power.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlatb2.xyz = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.xyzx).xyz;
					    {
					        vec4 hlslcc_movcTemp = u_xlat0;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? u_xlat1.x : u_xlat0.x;
					        hlslcc_movcTemp.y = (u_xlatb2.y) ? u_xlat1.y : u_xlat0.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? u_xlat1.z : u_xlat0.z;
					        u_xlat0 = hlslcc_movcTemp;
					    }
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat1 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat12 = min(u_xlat1.y, u_xlat1.w);
					    u_xlat12 = (-u_xlat12) + u_xlat1.x;
					    u_xlat2.x = u_xlat12 * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat1.y) + u_xlat1.w;
					    u_xlat5.x = u_xlat5.x / u_xlat2.x;
					    u_xlat5.x = u_xlat5.x + u_xlat1.z;
					    u_xlat1.x = u_xlat1.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat12 / u_xlat1.x;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat1 = texture(_Curves, u_xlat2.xy).yxzw;
					    u_xlat2 = texture(_Curves, u_xlat10.xy).zxyw;
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat12 = u_xlat2.x + u_xlat2.x;
					    u_xlat1.x = u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat1.x = u_xlat1.x + u_xlat1.x;
					    u_xlat12 = u_xlat12 * u_xlat1.x;
					    u_xlat1.x = dot(u_xlat0.xyz, vec3(0.212599993, 0.715200007, 0.0722000003));
					    u_xlat0.xyz = u_xlat0.xyz + (-u_xlat1.xxx);
					    u_xlat1.y = float(0.25);
					    u_xlat9.y = float(0.25);
					    u_xlat2 = texture(_Curves, u_xlat1.xy).wxyz;
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat5.x = u_xlat2.x + u_xlat2.x;
					    u_xlat12 = u_xlat12 * u_xlat5.x;
					    u_xlat12 = u_xlat12 * _Saturation;
					    u_xlat0.xyz = vec3(u_xlat12) * u_xlat0.xyz + u_xlat1.xxx;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Contrast, _Contrast, _Contrast)) + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb2 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb1.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat6.x = (u_xlatb2.y) ? u_xlat0.x : float(65504.0);
					    u_xlat6.z = (u_xlatb2.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb1.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat2.x = (u_xlatb2.x) ? u_xlat0.x : u_xlat6.x;
					    u_xlat2.y = (u_xlatb2.z) ? u_xlat0.y : u_xlat6.z;
					    u_xlat2.z = (u_xlatb1.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xyz);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat2.xyz * _Balance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = (-_Lift.xyz) + vec3(1.0, 1.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * _Gain.xyz;
					    u_xlat3.xyz = _Lift.xyz * _Gain.xyz;
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlatb3.xyz = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.xyzx).xyz;
					    {
					        vec4 hlslcc_movcTemp = u_xlat0;
					        hlslcc_movcTemp.x = (u_xlatb3.x) ? u_xlat2.x : u_xlat0.x;
					        hlslcc_movcTemp.y = (u_xlatb3.y) ? u_xlat2.y : u_xlat0.y;
					        hlslcc_movcTemp.z = (u_xlatb3.z) ? u_xlat2.z : u_xlat0.z;
					        u_xlat0 = hlslcc_movcTemp;
					    }
					    u_xlat0.xyw = max(u_xlat0.yzx, vec3(0.0, 0.0, 0.0));
					    u_xlatb1.x = u_xlat0.x>=u_xlat0.y;
					    u_xlat1.x = u_xlatb1.x ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat0.yx;
					    u_xlat3.xy = u_xlat0.xy + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat1.xxxx * u_xlat3 + u_xlat2;
					    u_xlatb1.x = u_xlat0.w>=u_xlat2.x;
					    u_xlat1.x = u_xlatb1.x ? 1.0 : float(0.0);
					    u_xlat0.xyz = u_xlat2.xyw;
					    u_xlat2.xyw = u_xlat0.wyx;
					    u_xlat2 = (-u_xlat0) + u_xlat2;
					    u_xlat0 = u_xlat1.xxxx * u_xlat2 + u_xlat0;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat9.x = abs(u_xlat4.x) + _HueShift;
					    u_xlat2 = texture(_Curves, u_xlat9.xy);
					    u_xlat2.x = u_xlat2.x;
					    u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					    u_xlat4.x = u_xlat2.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat9.x;
					    u_xlatb8.x = 1.0<u_xlat4.x;
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat8 = (u_xlatb8.x) ? u_xlat5.y : u_xlat4.x;
					    u_xlatb4 = u_xlat4.x<0.0;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat8;
					    u_xlat4.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat4.xyz = fract(u_xlat4.xyz);
					    u_xlat4.xyz = u_xlat4.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat4.xyz = abs(u_xlat4.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.xyz = clamp(u_xlat4.xyz, 0.0, 1.0);
					    u_xlat4.xyz = u_xlat4.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat1.x / u_xlat5.x;
					    u_xlat4.xyz = u_xlat1.xxx * u_xlat4.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat0.xyz = u_xlat4.xyz * u_xlat0.xxx;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat4.x = dot(vec3(0.695452213, 0.140678704, 0.163869068), u_xlat1.xyz);
					    u_xlat4.y = dot(vec3(0.0447945632, 0.859671116, 0.0955343172), u_xlat1.xyz);
					    u_xlat4.z = dot(vec3(-0.00552588282, 0.00402521016, 1.00150073), u_xlat1.xyz);
					    u_xlat1.xyz = (-u_xlat4.yxz) + u_xlat4.zyx;
					    u_xlat1.xy = u_xlat4.zy * u_xlat1.xy;
					    u_xlat0.x = u_xlat1.y + u_xlat1.x;
					    u_xlat0.x = u_xlat4.x * u_xlat1.z + u_xlat0.x;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat1.x = u_xlat4.y + u_xlat4.z;
					    u_xlat1.x = u_xlat4.x + u_xlat1.x;
					    u_xlat0.x = u_xlat0.x * 1.75 + u_xlat1.x;
					    u_xlat1.x = u_xlat0.x * 0.333333343;
					    u_xlat1.x = 0.0799999982 / u_xlat1.x;
					    u_xlat5.x = min(u_xlat4.z, u_xlat4.y);
					    u_xlat5.x = min(u_xlat4.x, u_xlat5.x);
					    u_xlat9.x = max(u_xlat4.z, u_xlat4.y);
					    u_xlat5.y = max(u_xlat4.x, u_xlat9.x);
					    u_xlat5.xyz = max(u_xlat5.xyy, vec3(1.00000001e-10, 1.00000001e-10, 0.00999999978));
					    u_xlat5.x = (-u_xlat5.x) + u_xlat5.y;
					    u_xlat1.y = u_xlat5.x / u_xlat5.z;
					    u_xlat1.xz = u_xlat1.xy + vec2(-0.5, -0.400000006);
					    u_xlati13 = int((0.0<u_xlat1.z) ? 0xFFFFFFFFu : uint(0));
					    u_xlati2 = int((u_xlat1.z<0.0) ? 0xFFFFFFFFu : uint(0));
					    u_xlat9.x = u_xlat1.z * 2.5;
					    u_xlat9.x = -abs(u_xlat9.x) + 1.0;
					    u_xlat9.x = max(u_xlat9.x, 0.0);
					    u_xlat9.x = (-u_xlat9.x) * u_xlat9.x + 1.0;
					    u_xlati13 = (-u_xlati13) + u_xlati2;
					    u_xlat13 = float(u_xlati13);
					    u_xlat9.x = u_xlat13 * u_xlat9.x + 1.0;
					    u_xlat9.x = u_xlat9.x * 0.0250000004;
					    u_xlat1.x = u_xlat1.x * u_xlat9.x;
					    u_xlatb13 = u_xlat0.x>=0.479999989;
					    u_xlatb0.x = 0.159999996>=u_xlat0.x;
					    u_xlat1.x = (u_xlatb13) ? 0.0 : u_xlat1.x;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat9.x : u_xlat1.x;
					    u_xlat0.x = u_xlat0.x + 1.0;
					    u_xlat2.yzw = u_xlat0.xxx * u_xlat4.xyz;
					    u_xlat4.x = (-u_xlat4.x) * u_xlat0.x + 0.0299999993;
					    u_xlat8 = u_xlat4.y * u_xlat0.x + (-u_xlat2.w);
					    u_xlat8 = u_xlat8 * 1.73205078;
					    u_xlat1.x = u_xlat2.y * 2.0 + (-u_xlat2.z);
					    u_xlat0.x = (-u_xlat4.z) * u_xlat0.x + u_xlat1.x;
					    u_xlat12 = max(abs(u_xlat0.x), abs(u_xlat8));
					    u_xlat12 = float(1.0) / u_xlat12;
					    u_xlat1.x = min(abs(u_xlat0.x), abs(u_xlat8));
					    u_xlat12 = u_xlat12 * u_xlat1.x;
					    u_xlat1.x = u_xlat12 * u_xlat12;
					    u_xlat9.x = u_xlat1.x * 0.0208350997 + -0.0851330012;
					    u_xlat9.x = u_xlat1.x * u_xlat9.x + 0.180141002;
					    u_xlat9.x = u_xlat1.x * u_xlat9.x + -0.330299497;
					    u_xlat1.x = u_xlat1.x * u_xlat9.x + 0.999866009;
					    u_xlat9.x = u_xlat12 * u_xlat1.x;
					    u_xlat9.x = u_xlat9.x * -2.0 + 1.57079637;
					    u_xlatb13 = abs(u_xlat0.x)<abs(u_xlat8);
					    u_xlat9.x = u_xlatb13 ? u_xlat9.x : float(0.0);
					    u_xlat12 = u_xlat12 * u_xlat1.x + u_xlat9.x;
					    u_xlatb1.x = u_xlat0.x<(-u_xlat0.x);
					    u_xlat1.x = u_xlatb1.x ? -3.14159274 : float(0.0);
					    u_xlat12 = u_xlat12 + u_xlat1.x;
					    u_xlat1.x = min(u_xlat0.x, u_xlat8);
					    u_xlat0.x = max(u_xlat0.x, u_xlat8);
					    u_xlatb0.x = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb8.x = u_xlat1.x<(-u_xlat1.x);
					    u_xlatb0.x = u_xlatb0.x && u_xlatb8.x;
					    u_xlat0.x = (u_xlatb0.x) ? (-u_xlat12) : u_xlat12;
					    u_xlat0.x = u_xlat0.x * 57.2957802;
					    u_xlatb8.xy = equal(u_xlat2.zwzw, u_xlat2.yzyz).xy;
					    u_xlatb8.x = u_xlatb8.y && u_xlatb8.x;
					    u_xlat0.x = (u_xlatb8.x) ? 0.0 : u_xlat0.x;
					    u_xlatb8.x = u_xlat0.x<0.0;
					    u_xlat12 = u_xlat0.x + 360.0;
					    u_xlat0.x = (u_xlatb8.x) ? u_xlat12 : u_xlat0.x;
					    u_xlatb8.x = 180.0<u_xlat0.x;
					    u_xlat1.xz = u_xlat0.xx + vec2(360.0, -360.0);
					    u_xlat8 = (u_xlatb8.x) ? u_xlat1.z : u_xlat0.x;
					    u_xlatb0.x = u_xlat0.x<-180.0;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat8;
					    u_xlat0.x = u_xlat0.x * 0.0148148146;
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat8 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat8;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat1.y * u_xlat0.x;
					    u_xlat0.x = u_xlat4.x * u_xlat0.x;
					    u_xlat2.x = u_xlat0.x * 0.180000007 + u_xlat2.y;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xzw);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xzw);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xzw);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.959999979, 0.959999979, 0.959999979) + vec3(u_xlat12);
					    u_xlat1.xyz = u_xlat0.xyz * vec3(278.508514, 278.508514, 278.508514) + vec3(10.7771997, 10.7771997, 10.7771997);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat2.xyz = u_xlat0.xyz * vec3(293.604492, 293.604492, 293.604492) + vec3(88.7121964, 88.7121964, 88.7121964);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xyz + vec3(80.6889038, 80.6889038, 80.6889038);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat0.x = dot(u_xlat1.xyz, vec3(1.0, 1.0, 1.0));
					    u_xlat0.x = max(u_xlat0.x, 9.99999975e-05);
					    u_xlat0.xy = u_xlat1.xy / u_xlat0.xx;
					    u_xlat12 = max(u_xlat1.y, 0.0);
					    u_xlat12 = min(u_xlat12, 65504.0);
					    u_xlat12 = log2(u_xlat12);
					    u_xlat12 = u_xlat12 * 0.981100023;
					    u_xlat1.y = exp2(u_xlat12);
					    u_xlat12 = (-u_xlat0.x) + 1.0;
					    u_xlat0.z = (-u_xlat0.y) + u_xlat12;
					    u_xlat4.x = max(u_xlat0.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat1.y / u_xlat4.x;
					    u_xlat1.xz = u_xlat4.xx * u_xlat0.xz;
					    u_xlat0.x = dot(vec3(1.6410234, -0.324803293, -0.236424699), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.663662851, 1.61533165, 0.0167563483), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.0117218941, -0.00828444213, 0.988394856), u_xlat1.xyz);
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.930000007, 0.930000007, 0.930000007) + vec3(u_xlat12);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat0.x = dot(vec3(0.987223983, -0.00611326983, 0.0159533005), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.00759836007, 1.00186002, 0.00533019984), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00307257008, -0.00509594986, 1.08168006), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(3.2409699, -1.5373832, -0.498610765), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.969243646, 1.8759675, 0.0415550582), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0556300804, -0.203976959, 1.05697155), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat1 = texture(_Curves, u_xlat0.xw).wxyz;
					    u_xlat1.x = u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat2 = texture(_Curves, u_xlat0.yw);
					    u_xlat0 = texture(_Curves, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat1.z = clamp(u_xlat1.z, 0.0, 1.0);
					    u_xlat1.y = u_xlat2.w;
					    u_xlat1.y = clamp(u_xlat1.y, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat1 = texture(_Curves, u_xlat0.xw);
					    SV_Target0.x = u_xlat1.x;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat1 = texture(_Curves, u_xlat0.yw);
					    u_xlat0 = texture(_Curves, u_xlat0.zw);
					    SV_Target0.z = u_xlat0.z;
					    SV_Target0.z = clamp(SV_Target0.z, 0.0, 1.0);
					    SV_Target0.y = u_xlat1.y;
					    SV_Target0.y = clamp(SV_Target0.y, 0.0, 1.0);
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
			}
		}
	}
}